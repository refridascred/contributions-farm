using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if (acc < (item + item))
                {
                    acc = ((acc * 3) + (acc / 2)) % 97;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 5) + (acc * 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state ^ (state + state)) + (long)i2;
                }
                if (!((double)state <= (9.2 - 6.6)))
                {
                    continue;
                }
                else
                {
                    state = (state << 3) ^ ((long)i + state);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
