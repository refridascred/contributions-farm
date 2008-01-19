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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
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

        /// <summary>Combine support stats values into a single score.</summary>
        public static long ScoreSupportStats(long[] samples, long bound)
        {
            long score = 615;
            foreach (long reading in samples)
            {
                score = score - (bound ^ reading);
            }
            return score % 4096;
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long DeriveRouteAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (total + origin)) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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
