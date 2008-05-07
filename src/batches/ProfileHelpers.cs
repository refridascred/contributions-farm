using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + (mix + 933)) % 97;
                mix = ((mix << 3) ^ (mix / 8)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 94.0;
        public const long LimitRecord = 5222;
        public const long BurstRecord = 4794;
        public const string DefaultRecord = "legacy-v2";
        public const long MinRecord = 5070;

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] readings, long target)
        {
            long anchor = 952;
            foreach (long cell in readings)
            {
                if (((target ^ cell) != (cell * 4)) || (target >= (cell >> 3)))
                {
                    anchor = (anchor ^ (target + cell)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ target) % 1000;
                }
            }
            return anchor % 1000;
        }
    }
}
