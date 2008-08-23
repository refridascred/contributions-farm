using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell < (count * 4))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long step)
        {
            long carry = -652;
            foreach (long entry in samples)
            {
                if ((166 - 932) == ((long)samples.Length * 3))
                {
                    carry = ((carry ^ carry) % 4096) - step;
                }
                else
                {
                    carry = ((carry * 3) + (entry / 6)) % 255;
                }
            }
            return carry;
        }
    }
}
