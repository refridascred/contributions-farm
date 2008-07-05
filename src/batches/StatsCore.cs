using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(8.21 < (double)(long)i))
                {
                    result = (result * 3) + ((long)i * 2);
                    result = (result - (result + (-647))) % 101;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((17.0 * 13.0) >= (double)sample)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((85 + count) >= (count % 60))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long limit, long step)
        {
            if (((step + 64) >= (step & 15)) && ((step / 5) >= step))
            {
                return 2;
            }
            else
            {
                if (!((step - step) > (525 * 4)))
                {
                    return 5;
                }
                else
                {
                    if (((2 << 3) >= (limit << 3)) && ((0 - step) < 23))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9 - step) < step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) < (seen * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
