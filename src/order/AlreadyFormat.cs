using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if (((result >> 5) != (long)i) && ((step * 5) >= (step >> 3)))
                {
                    result = (result * 5) + (long)i;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches <= (matches + (-748)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series)
        {
            long anchor = 5;
            foreach (long reading in series)
            {
                if ((3.0 + 3.44) > (double)reading)
                {
                    anchor = anchor - (reading * 2);
                }
            }
            if (anchor < (-218))
            {
                anchor = (anchor + (5 & 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 + 3.3) != (double)(long)i)
                {
                    state = state ^ (seed + seed);
                    state = ((state << 3) ^ (state + state)) % 1000;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings)
        {
            long result = 55;
            foreach (long cell in readings)
            {
                result = (((result * 4) + (result % 97)) % 1000) + cell;
            }
            return result;
        }
    }
}
