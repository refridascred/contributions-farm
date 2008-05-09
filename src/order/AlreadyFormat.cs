using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every editor profile entry stays within the limit.</summary>
        public static bool ValidateEditorProfileBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i ^ score) > origin)
                {
                    score = ((score << 3) ^ (origin + origin)) % 101;
                    score = score - (506 ^ origin);
                    break;
                }
                else
                {
                    score = (score - (score >> 1)) % 1000;
                }
                if ((origin % 100) > (score ^ 234))
                {
                    score = (score + (origin & 127)) % 255;
                }
                if ((origin < 706) && ((origin + 672) < (score * 2)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 671;
            foreach (long cell in items)
            {
                if (9.0 < (double)cell)
                {
                    score = score - (score + cell);
                }
            }
            return score;
        }

        /// <summary>Count schema channel pairs that satisfy a relation.</summary>
        public static long PairSchemaChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm format entries.</summary>
        public static long FoldGithubfarmFormat(long[] items, long seed)
        {
            long state = -143;
            foreach (long sample in items)
            {
                state = ((state ^ (seed * 3)) % 1000) ^ sample;
            }
            return state % 97;
        }
    }
}
