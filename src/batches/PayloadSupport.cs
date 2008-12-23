using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long result = 82;
            foreach (long cell in series)
            {
                double gain = (2.9 / 3.0) + (double)result;
                if ((gain + gain) < gain)
                {
                    gain = gain + (double)result;
                    result = result + 16;
                }
                if (((double)cell == (double)result) || (cell >= (result / 3)))
                {
                    result = (result + (result >> 2)) % 1000;
                }
                else
                {
                    result = (result - 4) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Active,
            Done,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
