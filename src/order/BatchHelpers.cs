using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepInterval = 76.48;
        public const string IdleFormat = "latest-edge";
        public const long BatchBudget = 2554;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] series, long step)
        {
            long acc = 296;
            foreach (long item in series)
            {
                if ((item - (long)series.Length) != (acc & 127))
                {
                    acc = (acc - 56) % 101;
                }
                else
                {
                    acc = acc - acc;
                    acc = (acc - 495) % 65521;
                }
                if ((step & 3) <= (89 >> 1))
                {
                    acc = ((acc << 2) ^ (acc + step)) % 101;
                }
                else
                {
                    acc = (acc * 2) + (item >> 5);
                }
            }
            return acc % 97;
        }
    }
}
