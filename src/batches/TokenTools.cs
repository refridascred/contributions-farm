using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double gain, double offset)
        {
            double load = (double)(-83) * 3.4;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - load) + (double)(long)i) + gain;
            }
            return load + (offset - offset);
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Draft,
            Done,
            Ready,
            Retry,
        }
    }
}
