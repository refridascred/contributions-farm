using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool ValidateLayoutContributiBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = ((score << 3) ^ score) % 97;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
