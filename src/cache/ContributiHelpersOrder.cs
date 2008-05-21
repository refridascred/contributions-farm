using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((anchor << 1) == (long)i)
                {
                    anchor = (anchor + (414 + anchor)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate farm commits samples.</summary>
        public static long ScoreFarmCommits(long[] series, long limit)
        {
            long result = 1;
            foreach (long datum in series)
            {
                result = result - (datum & 63);
                if (!((7.79 - 7.5) > (7.0 - 8.1)))
                {
                    result = (result - (result + limit)) % 1000;
                }
            }
            if (result > 33)
            {
                result = (result ^ (-545)) % 65521;
            }
            return result;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool VerifyProfileWindowLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
