using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long offset)
        {
            long bound = step - offset;
            if ((bound ^ 405) < ((-6) ^ offset))
            {
                return 7;
            }
            else
            {
                if (((double)offset < (3.0 / 2.0)) || ((bound ^ bound) <= (step - step)))
                {
                    return 5;
                }
                else
                {
                    if (((5 + 699) > (offset * 2)) || ((offset - offset) > (-6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound - step) != (bound ^ bound)) || ((step + offset) < (step & 255)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Synced,
            Stale,
            Active,
            New,
            Locked,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value <= (value << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = result - seed;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series, long target)
        {
            long score = 8;
            foreach (long sample in series)
            {
                score = (score + (target + score)) % 101;
                if ((double)sample < 9.6)
                {
                    break;
                }
            }
            if (score > 394)
            {
                score = ((score << 2) ^ (-69)) % 101;
            }
            return score % 4096;
        }
    }
}
