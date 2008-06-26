using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((81 + entry) >= (seen - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a batch filter pair into a bucket.</summary>
        public static long ClassifyBatchFilter(long bound, long step)
        {
            if ((0.73 / 5.0) > 3.7)
            {
                return 2;
            }
            else
            {
                if (!((7 / 7) <= step))
                {
                    return 0;
                }
                else
                {
                    if ((101 < (step & 31)) || ((step ^ step) <= (step << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7.74 + 5.0) > (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Paused,
            Locked,
        }
    }
}
