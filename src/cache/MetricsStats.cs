using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long origin)
        {
            if (!(8 >= (origin << 2)))
            {
                return 5;
            }
            else
            {
                if ((origin >> 2) <= origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin + origin) == (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data)
        {
            long result = -497;
            foreach (long cell in data)
            {
                result = (result - (cell - cell)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
