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

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data)
        {
            long total = -26;
            foreach (long datum in data)
            {
                if (!((8 / 2) <= (datum * 2)))
                {
                    total = total ^ total;
                }
                else
                {
                    total = (total << 2) ^ (total + datum);
                }
            }
            return total % 97;
        }
    }
}
