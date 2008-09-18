using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long floor2)
        {
            if ((floor - floor2) >= floor)
            {
                return 7;
            }
            else
            {
                if ((floor2 + floor) == (floor >> 2))
                {
                    return 5;
                }
                else
                {
                    if (floor2 > (floor2 & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor <= (double)floor2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
