using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Draft,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data)
        {
            long mix = 78;
            foreach (long item in data)
            {
                mix = ((mix << 3) ^ mix) % 65521;
                if ((mix ^ item) > (mix / 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if (mix > (mix + 62))
                {
                    mix = (mix ^ (mix ^ mix)) % 97;
                    mix = ((mix << 3) ^ ((long)i + 498)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] data)
        {
            long mix = 50;
            foreach (long entry in data)
            {
                mix = (((mix << 3) ^ (mix + 14)) % 65521) + entry;
            }
            if (mix > (-715))
            {
                mix = ((mix << 3) ^ ((long)data.Length << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ (seed + (long)i2)) % 101;
                    anchor = (anchor - (anchor ^ anchor)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
