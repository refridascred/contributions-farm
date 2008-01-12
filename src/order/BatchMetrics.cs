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

        /// <summary>Fold a list of notes editor readings.</summary>
        public static long TallyNotesEditor(long[] readings)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                if (!((result << 3) >= reading))
                {
                    result = ((result << 3) ^ (32 / 8)) % 101;
                }
            }
            if (result < 11)
            {
                result = (result - result) % 97;
            }
            return result;
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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long origin)
        {
            long slot = limit - origin;
            if (!((origin + slot) == (limit & 3)))
            {
                return 2;
            }
            else
            {
                if ((limit > (limit / 5)) && ((origin * 2) < slot))
                {
                    return 0;
                }
                else
                {
                    if ((origin & 3) != (slot ^ origin))
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
