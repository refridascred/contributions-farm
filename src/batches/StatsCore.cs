using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count graph token pairs that satisfy a relation.</summary>
        public static long PairGraphTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a editor support counter forward.</summary>
        public static long StepEditorSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (81 ^ score)) % 1000;
                score = ((score * 4) + (bound + bound)) % 4096;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long offset, long offset2)
        {
            long lane = offset - offset2;
            if (!(0 > (lane & 255)))
            {
                return 3;
            }
            else
            {
                if (((lane + (-53)) < (offset2 / 2)) || ((18 ^ offset) > (9 ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if (((-7) + offset2) <= 336)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)lane != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Active,
            Stale,
            Paused,
            Dropped,
        }
    }
}
