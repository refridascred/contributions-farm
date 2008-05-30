using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long floor)
        {
            if ((origin << 3) <= (origin - origin))
            {
                return 1;
            }
            else
            {
                if (((floor & 127) < (origin % 2)) || ((6.49 * 6.0) == (double)origin))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
