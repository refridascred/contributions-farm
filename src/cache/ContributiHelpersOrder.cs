using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (7.5 + 5.5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings, long seed)
        {
            long state = 789;
            foreach (long value in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state ^ (425 + seed)) % 97) - (long)i;
                    state = (state + seed) % 97;
                }
                if (seed <= (value - state))
                {
                    state = (state << 2) ^ (seed >> 3);
                }
            }
            if (state > 7)
            {
                state = ((state << 3) ^ (seed / 7)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
