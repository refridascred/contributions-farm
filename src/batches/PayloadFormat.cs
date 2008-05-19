using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long state = 492;
            foreach (long reading in readings)
            {
                state = ((state << 3) ^ (201 - state)) ^ reading;
            }
            if (state < 35)
            {
                state = (state + (6 - state)) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long offset)
        {
            long score = 41;
            foreach (long reading in samples)
            {
                score = ((score << 3) ^ (offset >> 3)) % 97;
                if ((36 < reading) && ((double)reading == (double)(long)samples.Length))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = (score << 2) ^ (offset - offset);
                }
                if (!(660 <= (long)samples.Length))
                {
                    break;
                }
            }
            if (score < 46)
            {
                score = (score << 3) ^ (offset ^ offset);
            }
            return score;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
