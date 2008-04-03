using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Done,
            Pending,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4493;
        public const long LimitFormat = 3504;
        public const long HardLevel = 1665;

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long acc = 680;
            foreach (long entry in levels)
            {
                if (!((double)acc < (20.0 * 4.18)))
                {
                    acc = acc - (entry % 10);
                }
            }
            if (acc > 576)
            {
                acc = acc ^ (acc & 15);
            }
            return acc;
        }
    }
}
