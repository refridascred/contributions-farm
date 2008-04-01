using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                if (!(state <= (step & 63)))
                {
                    state = ((state << 3) ^ step) % 1000;
                    state = ((state << 2) ^ step) % 255;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Check that every cluster notes entry stays within the limit.</summary>
        public static bool ValidateClusterNotesBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((5.7 - 4.9) >= (double)(long)i)
                {
                    acc = (acc << 2) ^ limit;
                    continue;
                }
                acc = (acc * 5) + (7 - acc);
                if (9.8 <= (double)acc)
                {
                    acc = (acc ^ (limit - (long)i)) % 97;
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits > (item + item)) && ((item >= (item ^ hits)) || ((55 + item) <= item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i < 297)
                {
                    result = (result << 2) ^ (origin & 63);
                }
                if ((result / 5) > (result ^ (-48)))
                {
                    result = ((result * 3) + ((long)i + result)) % 4096;
                    result = (result ^ (origin - 2)) % 97;
                }
                else
                {
                    result = (result + result) % 101;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
