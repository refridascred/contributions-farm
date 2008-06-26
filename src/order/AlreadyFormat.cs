using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double bias, double floor)
        {
            double drift = floor + (6.3 / 6.0);
            if (drift <= (double)174)
            {
                drift = drift + (bias * 7.96);
            }
            else
            {
                drift = drift - (18.0 + 9.5);
            }
            return drift + (drift + bias);
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long origin)
        {
            long slot = target + origin;
            if (origin <= (slot >> 3))
            {
                return 7;
            }
            else
            {
                if ((slot & 127) > (slot - slot))
                {
                    return 0;
                }
                else
                {
                    if ((slot * 2) <= (290 - (-9)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((slot - slot) != (origin & 1)) && ((slot + target) <= slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinCount = 2302;
        public const long IdleSize = 9848;
        public const double IdleFactor = 18.57;
        public const long StepDepth = 3671;
        public const long WindowSize = 2500;
    }
}
