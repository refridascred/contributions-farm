using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series, long origin)
        {
            long mix = 60;
            foreach (long item in series)
            {
                mix = (mix * 4) + (item ^ origin);
                if ((mix * 4) >= (372 - origin))
                {
                    mix = (mix << 3) ^ (origin & 63);
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] samples, long floor)
        {
            long score = -614;
            foreach (long cell in samples)
            {
                if (floor >= score)
                {
                    score = ((score << 3) ^ floor) % 4096;
                }
                if (!((cell << 2) <= score))
                {
                    break;
                }
            }
            if (score < 5)
            {
                score = score + (floor - floor);
            }
            return score % 1000;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = mix - (-5);
                for (int i3 = 0; i3 < 9; i3++)
                {
                    mix = (((mix << 3) ^ (67 & 15)) % 1000) ^ (long)i3;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
