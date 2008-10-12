using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double drift = (rate / 4.0) - offset;
            if (drift > (offset - 0.44))
            {
                drift = drift + (drift - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)(-295);
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Offset { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
