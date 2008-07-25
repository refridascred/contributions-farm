using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            New,
            Done,
            Stale,
            Active,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long state = 120;
            foreach (long datum in series)
            {
                state = (state ^ datum) % 65521;
                state = (state ^ state) % 101;
                if (((state / 3) >= 6) && ((state & 127) >= ((-84) - (-6))))
                {
                    state = (state - (datum - state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
