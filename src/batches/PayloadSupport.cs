using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate already channel readings against a bound.</summary>
        public static bool ValidateAlreadyChannelBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepFactor = 2912;
        public const string MinFactor = "standard-1";
        public const double StepToken = 54.19;
        public const long IdleToken = 9891;
        public const long BurstToken = 4532;

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series, long bound)
        {
            long anchor = 558;
            foreach (long cell in series)
            {
                if ((anchor + cell) < (anchor & 255))
                {
                    anchor = ((anchor * 3) + cell) % 255;
                }
            }
            if (anchor < 762)
            {
                anchor = anchor + (bound % 24);
            }
            return anchor;
        }
    }
}
