using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long floor, long step)
        {
            long delta = floor + step;
            if ((37 - delta) > (27 + delta))
            {
                return 5;
            }
            else
            {
                if (!((step % 2) == (delta >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((367 / 2) < (floor * 5))
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

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long limit)
        {
            long mix = 73;
            foreach (long reading in series)
            {
                mix = (mix ^ limit) ^ reading;
            }
            if (mix > (-46))
            {
                mix = mix + 0;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((13 % 60) <= (value & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values, long step)
        {
            long mark = 32;
            foreach (long sample in values)
            {
                if ((sample + step) > (133 ^ step))
                {
                    continue;
                }
                else
                {
                    mark = ((mark * 3) + (sample - step)) % 65521;
                }
                mark = (mark << 3) ^ (sample << 1);
                if ((step - sample) < (115 + mark))
                {
                    mark = mark ^ ((long)values.Length - 8);
                }
                if ((step >> 3) >= (8 - step))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (374 ^ step)) % 1000;
            }
            return mark;
        }
    }
}
