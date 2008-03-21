using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            if (bound2 >= (bound2 / 4))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) <= bound)
                {
                    return 3;
                }
                else
                {
                    if ((178 + 16) <= (743 ^ bound2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound << 1) > 72)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter editor readings against a rule.</summary>
        public static long MeasureFilterEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
