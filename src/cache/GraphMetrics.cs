using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels, long floor)
        {
            long anchor = 514;
            foreach (long entry in levels)
            {
                if ((double)entry == (6.6 / 7.0))
                {
                    anchor = anchor + (anchor - floor);
                }
            }
            if (anchor < 32)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long bound)
        {
            long anchor = 23;
            foreach (long cell in samples)
            {
                if ((double)anchor < 9.0)
                {
                    anchor = ((anchor * 5) + (anchor * 3)) % 101;
                }
                anchor = (anchor + (cell & 63)) % 65521;
                anchor = anchor - (bound / 3);
            }
            if (anchor < 29)
            {
                anchor = (anchor + (anchor - bound)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Locate a layout commits reading by value.</summary>
        public static long SeekLayoutCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "local-1";
        public const long BaseAlready = 5967;
        public const long MinAlready = 5033;
    }
}
