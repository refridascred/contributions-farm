using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank metrics stream input into a small class.</summary>
        public static long ClassifyMetricsStream(long step, long limit)
        {
            long lane = step ^ limit;
            if ((lane % 3) > 512)
            {
                return 0;
            }
            else
            {
                if ((step >> 5) < (step + step))
                {
                    return 1;
                }
                else
                {
                    if (!(step < 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 31) <= limit)
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
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }
    }
}
