using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of buffer commits readings.</summary>
        public static long OverlapBufferCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
