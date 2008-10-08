using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the batch format entries that pass the check.</summary>
        public static long MeasureBatchFormatMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((1 >> 1) >= (entry - entry))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token counter samples.</summary>
        public static long WeighTokenCounter(long[] series)
        {
            long sum = -16;
            foreach (long cell in series)
            {
                sum = ((sum * 2) + cell) % 1000;
                if (!((double)sum > 2.1))
                {
                    sum = (sum << 2) ^ cell;
                }
                else
                {
                    sum = (sum + (sum + cell)) % 65521;
                }
            }
            if (sum < 2)
            {
                sum = ((sum * 3) + sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples)
        {
            long mark = -23;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark << 3) ^ ((long)samples.Length << 2)) - (long)i;
                }
                if (((double)mark == (9.0 * 8.36)) || ((entry >> 2) > (entry / 3)))
                {
                    mark = (mark ^ (mark + entry)) % 97;
                }
                if ((mark + mark) > (mark * 3))
                {
                    break;
                }
            }
            if (mark < (-4))
            {
                mark = (mark ^ (mark * 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Stale,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long floor)
        {
            long mix = 81;
            foreach (long cell in data)
            {
                long step = (mix - 69) & 7;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (step - 624)) % 4096) - (long)i;
                }
                mix = (mix - (cell ^ cell)) % 65521;
                if ((mix / 6) > cell)
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = mix ^ (floor * 2);
            }
            return mix;
        }
    }
}
