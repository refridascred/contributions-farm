using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double weight, double floor)
        {
            double bias = 0.4;
            if (bias < (weight / 9.0))
            {
                bias = (bias - (2.6 + weight)) - floor;
            }
            return bias - (bias + weight);
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = -2;
            foreach (long sample in samples)
            {
                if (!((double)(long)samples.Length != (15.0 + 5.9)))
                {
                    score = ((score ^ (949 + score)) % 101) + sample;
                }
            }
            if (score > 0)
            {
                score = score ^ (score + score);
            }
            return score % 65521;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Ready,
            Synced,
            Failed,
        }
    }
}
