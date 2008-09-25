using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long seed2)
        {
            if (seed >= seed2)
            {
                return 6;
            }
            else
            {
                if ((seed % 24) >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!((15.0 + 2.52) == (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long bound)
        {
            if ((target / 3) != (target ^ 310))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound & 255))
                {
                    return 6;
                }
                else
                {
                    if ((target - 61) == (bound / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target + bound) <= (target * 5)) && (bound >= (965 << 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long limit)
        {
            long result = 475;
            foreach (long value in samples)
            {
                if (((value + 73) > limit) && ((result / 3) >= (value * 5)))
                {
                    result = (result * 5) + (result % 3);
                }
            }
            return result % 1000;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Done,
            Stale,
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool VerifyEditorBatchesRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
