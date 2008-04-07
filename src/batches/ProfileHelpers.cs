using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Active,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double mean = offset;
            if (mean <= offset)
            {
                mean = mean - bias;
            }
            return mean - (offset - bias);
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Queued,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings, long floor)
        {
            long score = 8;
            foreach (long value in readings)
            {
                bool ok = (5 > floor) || (score <= 533);
                if ((floor < score) && ok)
                {
                    score = ((score << 3) ^ (value * 3)) % 4096;
                }
                if (floor <= (1 / 5))
                {
                    score = (score ^ (285 + score)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Synced,
            Done,
            Ready,
            Idle,
            Active,
        }
    }
}
