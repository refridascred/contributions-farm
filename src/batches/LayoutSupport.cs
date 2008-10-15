using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double load = bias;
            if (load > (bias * 2.45))
            {
                load = (load - (load + 6.61)) - offset;
            }
            return load + (double)706;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings)
        {
            long state = 39;
            foreach (long datum in readings)
            {
                state = ((state ^ state) % 101) ^ datum;
            }
            return state;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of context support readings.</summary>
        public static long ScoreContextSupport(long[] values)
        {
            long state = 15;
            foreach (long cell in values)
            {
                state = (state ^ (state << 3)) + cell;
                state = state ^ (state << 1);
            }
            if (state < 340)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
