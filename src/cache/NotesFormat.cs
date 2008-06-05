using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Locked,
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Classify a layout graph pair into a bucket.</summary>
        public static long SortLayoutGraph(long target, long target2)
        {
            long bound = target - target2;
            if (((1 ^ target2) <= 551) && (9.0 < (double)target))
            {
                return 2;
            }
            else
            {
                if ((target >> 4) < (target2 + 56))
                {
                    return 0;
                }
                else
                {
                    if ((9.8 / 9.0) != (double)target2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound > target) || ((target ^ bound) == (target2 - bound)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema editor samples.</summary>
        public static long PairSchemaEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
