using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate token batch readings against a bound.</summary>
        public static bool VerifyTokenBatchRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long mark = 77;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark ^ (long)series.Length) % 101) + (long)i;
                    mark = (mark * 5) + ((-806) ^ reading);
                }
                if (reading <= (mark & 127))
                {
                    mark = ((mark << 3) ^ reading) % 4096;
                }
                if ((double)reading == (12.0 + 5.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long acc = 250;
            foreach (long sample in data)
            {
                acc = (acc ^ (acc << 3)) ^ sample;
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 768;
        public const long DefaultTimeout = 9322;
        public const long WindowLayout = 5155;
        public const long StepLayout = 8079;
    }
}
