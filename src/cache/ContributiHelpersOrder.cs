using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            New,
            Ready,
            Idle,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((step << 1) >= (step2 + 53))
            {
                return 7;
            }
            else
            {
                if ((5.19 / 3.0) > (double)step2)
                {
                    return 8;
                }
                else
                {
                    if ((5.52 / 9.0) == (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
