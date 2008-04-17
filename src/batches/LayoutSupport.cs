using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepInterval = 49.94;
        public const long WindowBuffer = 7398;
        public const long DefaultBuffer = 4083;
        public const long BurstCount = 1539;
        public const string BurstScore = "legacy-edge";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long origin)
        {
            long step = bound ^ origin;
            if (!((944 / 3) >= (origin >> 5)))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((origin + 816) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (origin >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
