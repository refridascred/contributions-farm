using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long anchor = 373;
            foreach (long datum in data)
            {
                if (anchor <= (anchor << 2))
                {
                    anchor = (anchor * 4) + (51 - datum);
                }
                anchor = (anchor * 3) + (datum & 127);
            }
            if (anchor < 91)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Derive the next queue graph value from a seed.</summary>
        public static long StepQueueGraph(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((12.0 / 3.0) < (double)target))
                {
                    state = ((state << 2) ^ state) % 65521;
                    state = (state ^ target) % 65521;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + origin) >= (hits / 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
