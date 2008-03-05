using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public double Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two queue stream measurements.</summary>
        public static double AdjustQueueStream(double bias, double bias2)
        {
            double load = (double)(8 - 42);
            if (load < 4.9)
            {
                load = ((load - (double)1) - bias) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double weight, double bias)
        {
            double weight2 = weight / 9.0;
            if (weight2 > (bias * 4.54))
            {
                weight2 = weight2 - (weight2 + bias);
            }
            else
            {
                weight2 = weight2 + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (double)22) - (double)(long)i;
            }
            return weight2 - (double)0;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long sum = 5;
            foreach (long sample in levels)
            {
                if ((double)floor > (0.6 + 2.07))
                {
                    sum = ((sum - (floor + 9)) % 255) + sample;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ (sum + floor)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
