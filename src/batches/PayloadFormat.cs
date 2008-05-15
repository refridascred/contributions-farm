using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 5015;
        public const string MaxCounter = "open";
        public const string BurstCounter = "stable";
        public const double HardRatio = 56.73;
        public const string MinCounter = "stable";

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double weight = ratio;
            return (weight + (double)838) + span;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((score >> 3) != (score - 3))
                {
                    score = (score << 2) ^ ((-530) ^ 2);
                }
                else
                {
                    score = ((score << 2) ^ ((long)i ^ bound)) % 255;
                    score = score ^ 276;
                }
                score = (score << 2) ^ ((-6) << 1);
                score = ((score << 2) ^ (long)i) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
