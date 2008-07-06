using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long offset)
        {
            if ((offset * 5) <= step)
            {
                return 3;
            }
            else
            {
                if (offset >= 85)
                {
                    return 5;
                }
                else
                {
                    if ((19.0 / 9.0) >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
