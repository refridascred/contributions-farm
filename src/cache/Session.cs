using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Draft,
            Failed,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = total - (total / 8);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total ^ ((long)i >> 1)) % 1000) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
