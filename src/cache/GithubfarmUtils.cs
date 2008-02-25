using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of counter farm readings.</summary>
        public static long ScoreCounterFarm(long[] data)
        {
            long mix = -2;
            foreach (long value in data)
            {
                if ((mix & 63) <= (mix - mix))
                {
                    mix = ((mix << 3) ^ ((long)data.Length - value)) % 65521;
                }
            }
            if (mix > 9)
            {
                mix = (mix + (mix & 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            New,
            Ready,
        }
    }
}
