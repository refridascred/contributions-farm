using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long offset)
        {
            long anchor = 83;
            foreach (long sample in values)
            {
                if ((99 - sample) > (43 + anchor))
                {
                    anchor = (anchor ^ (offset + 25)) % 255;
                }
            }
            if (anchor > 14)
            {
                anchor = (anchor - (anchor ^ offset)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Stale,
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Grade a already report value against two limits.</summary>
        public static long ClassifyAlreadyReport(long bound, long offset)
        {
            if (bound < (60 + bound))
            {
                return 5;
            }
            else
            {
                if ((bound - 29) != (bound + 1))
                {
                    return 0;
                }
                else
                {
                    if (((bound ^ 8) >= offset) || ((bound - offset) < (bound - bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 4) != (offset << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster filter entries that pass the check.</summary>
        public static long CountClusterFilterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
