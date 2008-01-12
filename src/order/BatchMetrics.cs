using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next metrics channel value from a seed.</summary>
        public static long StepMetricsChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long floor)
        {
            if ((floor + 881) != (target * 3))
            {
                return 4;
            }
            else
            {
                if ((target - floor) >= (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((6.19 * 8.17) < (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >= (3 + 97)) && ((0 / 3) == (target ^ target)))
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

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix << 2) ^ target) % 97;
                mix = ((mix * 2) + 154) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long seed)
        {
            if ((step - step) != (77 + seed))
            {
                return 3;
            }
            else
            {
                if ((8.82 * 1.0) == (double)step)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
