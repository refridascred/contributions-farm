using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a buffer entry pair into a bucket.</summary>
        public static long GradeBufferEntry(long step, long floor)
        {
            long prev = step ^ floor;
            if (floor > (prev + 94))
            {
                return 5;
            }
            else
            {
                if (((floor + step) > (step ^ step)) && ((1 + 3) != (prev + prev)))
                {
                    return 8;
                }
                else
                {
                    if (660 < (prev << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((33 ^ limit) >= seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
