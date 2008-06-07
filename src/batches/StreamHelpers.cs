using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the payload batches series from a seed.</summary>
        public static long DerivePayloadBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (total ^ total)) % 1000;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first metrics farm entry that matches the target.</summary>
        public static long LookupMetricsFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a tools stats value against two limits.</summary>
        public static long BucketToolsStats(long bound, long bound2)
        {
            if ((double)bound2 != (double)51)
            {
                return 4;
            }
            else
            {
                if ((bound2 - bound2) > 1)
                {
                    return 8;
                }
                else
                {
                    if ((bound2 % 97) > (bound2 % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((2.56 - 7.0) > (double)bound2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] values)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                carry = (carry + datum) % 4096;
                if ((double)datum >= (9.2 + 4.82))
                {
                    carry = carry + (918 % 97);
                }
                else
                {
                    carry = (carry + 219) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 819;
        public const double WindowCounter = 63.34;
        public const double BaseCounter = 77.76;
        public const double StepSpan = 69.58;
        public const string MinCounter = "staging";
    }
}
