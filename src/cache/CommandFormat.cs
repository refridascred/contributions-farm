using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine order githubfarm values into a single score.</summary>
        public static long WeighOrderGithubfarm(long[] samples)
        {
            long score = -813;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (score ^ (cell * 5)) - (long)i;
                }
                score = ((score * 5) + (cell - 299)) % 97;
                score = ((score << 2) ^ (cell & 15)) % 255;
            }
            if (score < 725)
            {
                score = (score + (3 - 148)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Idle,
            Locked,
            Queued,
        }
    }
}
