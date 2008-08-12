using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine profile counter values into a single score.</summary>
        public static long ScoreProfileCounter(long[] values, long limit)
        {
            long anchor = 414;
            foreach (long datum in values)
            {
                anchor = ((anchor ^ (limit % 100)) % 255) ^ datum;
            }
            if (anchor < 429)
            {
                anchor = (anchor << 2) ^ ((long)values.Length * 3);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of checks batch readings.</summary>
        public static long WeighChecksBatch(long[] readings, long origin)
        {
            long mix = 2;
            foreach (long sample in readings)
            {
                mix = (mix << 3) ^ (mix & 7);
                if ((mix - mix) < ((long)readings.Length - origin))
                {
                    mix = (mix << 2) ^ (sample - origin);
                    continue;
                }
                if ((origin << 1) <= (origin >> 1))
                {
                    mix = (mix ^ ((-4) + mix)) % 65521;
                }
                else
                {
                    mix = (mix - sample) % 97;
                }
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen % 64) > (seen ^ 426))
                {
                    seen = ((seen + 3) + cell) - step;
                }
            }
            return seen;
        }
    }
}
