using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples, long step)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                if (score > ((-75) >> 5))
                {
                    score = (((score << 3) ^ (cell * 2)) % 65521) - step;
                }
                else
                {
                    score = (score ^ (13 << 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] values, long offset)
        {
            long state = -57;
            foreach (long cell in values)
            {
                if ((double)cell < (3.0 - 4.1))
                {
                    state = (state - (state - state)) % 97;
                }
            }
            if (state > 1)
            {
                state = state + offset;
            }
            return state;
        }
    }
}
