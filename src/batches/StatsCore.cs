using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double load = offset;
            return (load + (double)849) + scale;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long step)
        {
            long acc = 97;
            foreach (long sample in data)
            {
                acc = (acc + (step + step)) % 97;
                if (((step & 3) <= (step >> 5)) && ((sample >> 3) == (step >> 3)))
                {
                    acc = acc - (acc * 5);
                }
                else
                {
                    acc = (acc << 2) ^ (acc >> 5);
                }
            }
            return acc;
        }

        /// <summary>Roll a checks command counter forward.</summary>
        public static long IterateChecksCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc << 3) ^ bound) % 101) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a githubfarm channel reading by value.</summary>
        public static long SeekGithubfarmChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Ready,
            Idle,
        }
    }
}
