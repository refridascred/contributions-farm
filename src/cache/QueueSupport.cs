using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long acc = 2;
            foreach (long datum in levels)
            {
                if ((8.71 - 12.0) > (double)datum)
                {
                    acc = ((acc * 5) + (7 + acc)) % 101;
                }
                if ((9.29 + 9.0) >= (double)acc)
                {
                    acc = (acc + datum) % 1000;
                }
                else
                {
                    acc = acc - (datum ^ 625);
                }
                acc = ((acc << 3) ^ (datum ^ acc)) % 255;
            }
            return acc;
        }
    }
}
