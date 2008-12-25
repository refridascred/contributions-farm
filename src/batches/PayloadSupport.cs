using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of tools payload entries.</summary>
        public static long CombineToolsPayload(long[] series, long offset)
        {
            long mix = 815;
            foreach (long reading in series)
            {
                mix = ((mix - (reading / 5)) % 101) - offset;
            }
            if (mix > 83)
            {
                mix = ((mix * 4) + (mix % 100)) % 101;
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally ^ 4) >= offset)
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score * 3) + bound) - (long)i2;
                    score = (score << 3) ^ (score >> 5);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
