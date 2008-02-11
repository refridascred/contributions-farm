using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a window filter counter forward.</summary>
        public static long IterateWindowFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long score = 88;
            foreach (long entry in values)
            {
                if (entry >= score)
                {
                    score = score ^ (score ^ seed);
                }
            }
            if (score < 8)
            {
                score = ((score << 3) ^ seed) % 255;
            }
            return score;
        }

        /// <summary>Validate context notes readings against a bound.</summary>
        public static bool ValidateContextNotesLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
