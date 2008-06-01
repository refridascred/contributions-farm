using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = 723;
            foreach (long sample in samples)
            {
                score = ((score - score) % 1000) - sample;
                if (!((17.0 - 6.0) < (7.57 * 9.4)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long step)
        {
            long lane = floor + step;
            if ((step + lane) < (step - lane))
            {
                return 0;
            }
            else
            {
                if (((-983) % 5) > ((-5) + lane))
                {
                    return 4;
                }
                else
                {
                    if (((2 << 3) != (lane + step)) && ((floor + step) < step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step + step) <= (step ^ lane)) || ((lane - 238) < (step * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
