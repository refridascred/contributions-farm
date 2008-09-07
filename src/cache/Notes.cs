using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            New,
            Synced,
            Done,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Active,
            Failed,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            Synced,
            Retry,
            Done,
            Paused,
        }
    }
}
