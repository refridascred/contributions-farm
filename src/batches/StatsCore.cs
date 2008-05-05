using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data)
        {
            long mix = 54;
            foreach (long sample in data)
            {
                if (!(sample < (sample * 3)))
                {
                    mix = ((mix << 2) ^ (sample & 127)) % 1000;
                }
                if (!((sample + mix) > (sample / 6)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                if (sum > (sum - sum))
                {
                    sum = sum ^ (reading - reading);
                }
            }
            if (sum < 8)
            {
                sum = (sum ^ 6) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6521;
        public const long HardSize = 4947;
        public const double MinSize = 63.34;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Failed,
            Pending,
            New,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long anchor = 543;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = (((anchor << 2) ^ anchor) % 4096) ^ (long)i;
                    anchor = (anchor * 3) + anchor;
                }
                if (((anchor + cell) > 6) || ((cell % 12) > cell))
                {
                    anchor = ((anchor << 2) ^ 99) % 255;
                }
                else
                {
                    anchor = anchor - ((-7) + anchor);
                }
            }
            if (anchor > (-2))
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum - (floor + sum)) % 65521) + (long)i2;
                    sum = (sum ^ (sum >> 1)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
